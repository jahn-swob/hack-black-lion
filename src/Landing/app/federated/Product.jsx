import React from "react";
import "./../styles/product.css";

const BuyButton = React.lazy(() => import("team-checkout/BuyButton"));

const Product = (props) => {
    return (
        <div className="product">
            <h3 style={{marginBottom: 20}}>{props.data.name}</h3>
            <span className="price">$ {props.data.price}</span>
                <React.Suspense fallback={<button>buy</button>}>
                    <BuyButton payload={{name: props.data.name, price: props.data.price, description: props.data.description}}>ADD TO CART</BuyButton>
                </React.Suspense>
        </div>
    )
}
export default Product;