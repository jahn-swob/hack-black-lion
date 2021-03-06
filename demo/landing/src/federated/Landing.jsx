import React from "react";
import "./../styles/index.css";
import { connect } from "react-redux";

import { products } from 'team-landing/MockedProducts';
const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
const ProductDetail = React.lazy(() => import("team-productdetail/ProductDetail"));
const ViewProductDetailButton = React.lazy(() => import("team-productdetail/ViewProductDetailButton"));
import Product from './Product';

const Landing = ({landingItems}) => {
   
  return (
    
    <div className="landingPage">
      <h2>Our Products</h2>
      <div className="productList">
      {
      landingItems.map((item, index) => {
        return (
          <div key={item.sku+index}>
          <React.Suspense fallback={<div>fallback product detail</div>}>
             <ProductDetail key={item.sku+index} item = {item}/>
           </React.Suspense>
              
           <React.Suspense fallback={<button>view detail fallback</button>}>
             <ViewProductDetailButton payload={{detailItem: item}}>view detail</ViewProductDetailButton>
           </React.Suspense>
           <React.Suspense fallback={<button>buy</button>}>
             <BuyButton payload={{name: item.name, price: item.price, description: item.description}}>BUY - ${item.price}</BuyButton>
           </React.Suspense>
           </div>
          )
      })
      }
      </div>
    </div>
  )

};
const mapStateToPros = state => ({
  landingItems: state.landingItems
})

export default connect(mapStateToPros)(Landing);