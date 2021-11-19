import React from "react";
import { connect } from "react-redux";
import "./../styles/index.css";

export const Search = () => {
  return (
    <div className="search-bar-container">
      <input
        placeholder="Search products..."
        type="text"
        className="search-input"
        onKeyDown={handleChange} />

      <button className="search-button" type="button" onClick={handleSubmit}>Search</button>
    </div>
  )
};

const handleChange = e => {
  console.log('hey');
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