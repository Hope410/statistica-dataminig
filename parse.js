const fs = require('fs').promises;

const dataSet = {
  BNBBTC: [],
  LTCBTC: [],
  ETHBTC: [],
  DASHBTC: [],
  XMRBNB: []
};
const tradeToRow = (t) => Object.values(t).map(v => v.toString().replace('.', ',')).join('\t') + '\t';

const parse = async () => {
  try{
    const coins = Object.keys(dataSet);

    for(let i = 0; i < coins.length; i++){
      let data = await fs.readFile(`./data/${coins[i]}.tsv`);
      data = data.toString().split('\n')
        .map((t, i, a) => t.split('\t')
          .map(v => v == 'true' ? 1 : v == 'false' ? 0 : +v.replace(',', '.'))
          .slice(0, 8));
  
      let increaseCount = 0;
      for(let i = 1; i < data.length; i++){
        if(data[i][1] > data[i-1][1]){
          if(increaseCount < 0) increaseCount = 0;
          data[i][7] = ++increaseCount;
        }else if(data[i][1] < data[i-1][1]){
          if(increaseCount > 0) increaseCount = 0;
          data[i][7] = --increaseCount;
        }else{
          increaseCount = 0;
        }
      }

      await fs.writeFile(`./parsed/${coins[i]}.tsv`, data.map(tradeToRow).join('\n'))
    }


    // console.table(data);
  }catch(e){
    console.log(e);
  }
}

parse();