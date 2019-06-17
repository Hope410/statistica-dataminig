const fs = require('fs').promises;

const generate = async () => {
  try{
    let coin = 'ETHBTC'
    let data = await fs.readFile(`./data/${coin}.csv`);
    data = data.toString().split('\n')
      .map((t, i, a) => t.split('\t')
        .map(v => v == 'true' ? 1 : v == 'false' ? 0 : +v.replace(',', '.'))
        .slice(0, 8));

    let lastEl = data[data.length-1];
    let price = lastEl[1];
    let epsilon = Math.pow(10, -(price.toString().length-4));
    let change = 0;

    console.log(price, epsilon);

    for(let i = 0; i < 100; i++){
      let newPrice = price + (Math.random()*2*epsilon - epsilon);
      if(newPrice > price){
        if(change < 0) change = 0;
        change++;
      }else if(newPrice < price){
        if(change > 0) change = 0;
        change--;
      }else{
        change = 0;
      }

      price = +newPrice.toString().slice(0, +lastEl[1].toString().length);

      console.log(`${change}`);
    }
  }catch(e){
    console.log(e);
  }
}

generate();
