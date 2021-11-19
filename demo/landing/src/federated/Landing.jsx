import React from "react";
import "./../styles/index.css";

import { products } from 'team-landing/MockedProducts';
const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
import Product from './Product';

const Landing = () => {
  return (
    <div className="landingPage">
      <h2>Our Products</h2>
      <div className="productList">
      {
      products.map((item, index) => {
        return (
          <>
          <Product data={ item } key={item.name}/>
          </>
          )
      })
      }
      </div>
    </div>
  )
};

export default Landing