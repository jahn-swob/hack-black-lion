import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import { products } from 'team-landing/MockedProducts';
import "./styles/index.css";

const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
const CheckoutFooter = React.lazy(() => import("team-checkout-footer/CheckoutFooter"));

const Main = () => {
  return (
    <div className="site">
      <div className="landingPage">
        <h2>Products (standalone)</h2>
        <div className="productList">
        {
        products.map((item, index) => {
          return (
            <div className="product" key={item.name}>
            <div style={{marginBottom: 20}}>{item.name}</div>
            <React.Suspense fallback={<button>buy</button>}>
            <BuyButton payload={{name: item.name, price: item.price, description: item.description}}>BUY - ${item.price}</BuyButton>
            </React.Suspense>
            </div>
            )
        })
        }
        </div>
        <React.Suspense fallback={<div>Header loading</div>}>
          <CheckoutFooter />
        </React.Suspense>
      </div>
    </div>
  )
};

const mapStateToProps = state => ( { } )

export default connect(mapStateToProps)(Main);
