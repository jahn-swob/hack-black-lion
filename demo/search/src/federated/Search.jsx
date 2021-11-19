import React from "react";
import { connect } from "react-redux";
import "./../styles/index.css";

const Search = () => {
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
    var string = "";
    var userInput = string += JSON.stringify(e.target.value);

    if (e.keyCode === 13) {
        handleSubmit(userInput.toString());
    }
}

const handleSubmit = userInput => {
    // fetch(`https://localhost:55006/Search?q=${userInput.toLowerCase()}`)
    fetch("https://localhost:7175/Search?q=plates")
      .then(res => res.json())
      .then(
        (result) => {
          console.log("result", result); // we have the result!!
          // searchProduct(result);
          setResults(result);
        },
        (error) => {
          console.error("ERROR WITH SEARCH RESULTS: ", error);
        }
      )
}

// const SearchButton = ({ payload, setResults, children }) => (
//   // <button className="checkoutButton" onClick={() => addToCart(payload)}>{children}</button>
//   <button className="search-button" onClick={() => setResults(payload)}>Search</button>
//   );
  
function searchProduct(payload) {
  return { type: 'landing/loadproducts', payload }
}
  
export default connect(null, (dispatch) => ({
  setResults: (payload) => dispatch(searchProduct(payload))
}))(Search);

// const searchProduct = userInput => dispatch => {
//   dispatch({
//     type: "landing/loadproducts",
//     userInput: userInput
//   });
// }

// const SearchButton = ({ payload, addToCart, children }) => (
//     <button className="checkoutButton" onClick={() => addToCart(payload)}>{children}</button>
//     );

// const mapStateToPros = state => ({ items: state.items });

// // export default connect(null, (dispatch) => ({
// //   addToCart: (payload) => dispatch(buyItem(payload))
// // }))(BuyButton);
// export default connect(mapStateToPros, {})(Search);