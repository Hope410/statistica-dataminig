const axios = require('axios');
const fs = require('fs').promises;

const dataSet = {
  BNBBTC: [],
  LTCBTC: [],
  ETHBTC: [],
  DASHBTC: [],
  XMRBNB: []
};
const address = (symbol) => `https://binance.com/api/v1/trades?symbol=${symbol}&limit=1000`;

let i = 0;

const tradeToRow = (t) => Object.values(t).map(v => v.toString().replace('.', ',')).join('\t') + '\t';

const mine = async () => {
  try{
    const coins = Object.keys(dataSet);

    if(i >= 30) {
      console.log(coins.map(c => `${c}: ${dataSet[c].length}`).join('\t'));

      await Promise.all(coins.map(async c =>  
        await fs.writeFile(`./data/${c}.csv`, dataSet[c].map(tradeToRow).join('\n'))));

      return clearInterval(interval);
    }
    
    await Promise.all(coins.map(async coin => {
      let coinSet = dataSet[coin];
      let { data } = await axios.get(address(coin));
      const lastTime = coinSet.length ? coinSet[coinSet.length - 1].time : 0;
  
      data = data.filter(t => t.time > lastTime);
      console.log(coin, data.length);
  
      dataSet[coin] = coinSet.concat(data);
    }))

    i++;
  }catch(e){
    console.log(e);
  }
}

mine();

const interval = setInterval(mine, 1000);