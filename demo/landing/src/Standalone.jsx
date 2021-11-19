import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import { products } from 'team-landing/MockedProducts';
import "./styles/index.css";

const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));
import Product from "./federated/Product";

const Main = () => {
  return (
      <div className="landingPage">
        <h2>Products (standalone)</h2>
        <div className="productList">
        {
        products.map((item, index) => {
          return (
              <Product data={item} key={item.name} />
            )
        })
        }
        </div>
      </div>
  )
};

const mapStateToProps = state => ( { } )

export default connect(mapStateToProps)(Main);
