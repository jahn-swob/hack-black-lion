
import React from "react";
import { connect } from "react-redux";
import "./../styles/index.css";
//import "./assets/BlueLion.png";
//import "./assets/RedLion.png";
//import "./assets/GreenLion.png";
//import "./assets/YellowLion.png";
//const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
//img src={require('./assets/'+item.image)} alt="image not found" />
const ProductDetail = ({item}) =>{
  if (item == null){
    item={sku: 'SKUBlackLion',name: 'Black Lion', price: 300, description: "Black Lion desc",image:"BlackLion.png"};
  }
  let imageName = require('./assets/'+item.image);
  
  return(
   <div  >
   <img src={imageName.default} width="100px"/>
   
     
   
   <h2>{item.name}</h2>
   </div>
  )
  
};
export default ProductDetail