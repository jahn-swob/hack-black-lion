import React from "react";
import { connect } from "react-redux";
import "./../styles/index.css";

export const Search = () => {
  return (
    <div className="checkoutPage">
      <h2>Search</h2>
      <input
        placeholder="Search products..."
        type="text"
        onKeyDown={handleChange} />

      <button type="button" onClick={handleSubmit}>Submit</button>
    </div>
  )
};

const handleChange = e => {
    var string = "";
    var userInput = string += JSON.stringify(e.target.value);

    if (e.keyCode === 13) {
        handleSubmit(userInput);
    }
}

const handleSubmit = userInput => {
    console.log("userInput", userInput)
}

// const SearchButton = ({ payload, addToCart, children }) => (
//     <button className="checkoutButton" onClick={() => addToCart(payload)}>{children}</button>
//     );

const mapStateToPros = state => ({ items: state.items });

// export default connect(null, (dispatch) => ({
//   addToCart: (payload) => dispatch(buyItem(payload))
// }))(BuyButton);
export default connect(mapStateToPros)(Search);