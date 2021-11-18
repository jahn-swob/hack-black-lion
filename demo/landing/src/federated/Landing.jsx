import React from "react";
import "./../styles/index.css";

import { products } from 'team-landing/MockedProducts';
const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
const CheckoutFooter = React.lazy(() => import("team-checkout-footer/CheckoutFooter"));

const Landing = () => {
  return (
    <div className="landingPage">
      <h2>Products</h2>
      <div className="productList">
      {
      products.map((item, index) => {
        return (
          <div className="product" key={item.name}>
          <div style={{marginBottom: 20}}>{item.name}</div>
          <React.Suspense fallback={<button>buy</button>}>
            <BuyButton payload={{name: item.name, price: item.price, description: item.description}}>BUY - ${item.price}</BuyButton>
            <CheckoutFooter />
          </React.Suspense>
          </div>
          )
      })
      }
      </div>
    </div>
  )
};

export default Landing