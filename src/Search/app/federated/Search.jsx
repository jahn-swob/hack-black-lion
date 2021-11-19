import React, { useState } from "react";
import { connect } from "react-redux";
import "./../styles/index.css";

const Search = (setResults) => {
    const [inputData, setInputData] = useState("");

    const handleClick = () => {
        fetch(`https://localhost:3100/Search?q=${inputData.toLowerCase()}`)
            .then(res => res.json())
            .then(
                (result) => {
                    //console.log("result", result); // we have the result!!
                    //searchProduct(result);
                    setResults(result);
                },
                (error) => {
                    console.error("ERROR WITH SEARCH RESULTS: ", error);
                }
            );
    };
    return (
        <div className="search-bar-container">
            <input
                placeholder="Search products..."
                type="text"
                className="search-input"
                onChange={e => setInputData(e.target.value)}/>

            <button className="search-button" type="button" onClick={handleClick}>Search</button>
        </div>
    );
};

const searchProduct = (payload) => {
    return { type: "landing/loadproducts", payload };
};

 export default connect(null, (dispatch) => ({
   setResults: (payload) => dispatch(searchProduct(payload))
 }))(Search);

//const handleChange = e => {
//    var string = "";
//    var userInput = string += JSON.stringify(e.target.value);

//    if (e.keyCode === 13) {
//        handleSubmit(userInput.toString());
//    }
//};

//const handleSubmit = userInput => {
//    console.log(userInput);
//    //fetch(`https://localhost:3100/Search?q=${userInput.toLowerCase()}`)
//    //    .then(res => res.json())
//    //    .then(
//    //        (result) => {
//    //            console.log("result", result); // we have the result!!
//    //            searchProduct(result);
//    //            //setResults(result);
//    //        },
//    //        (error) => {
//    //            console.error("ERROR WITH SEARCH RESULTS: ", error);
//    //        }
//    //    );
//};

// const SearchButton = ({ payload, setResults, children }) => (
//   // <button className="checkoutButton" onClick={() => addToCart(payload)}>{children}</button>
//   <button className="search-button" onClick={() => setResults(payload)}>Search</button>
//   );




// const searchProduct = userInput => dispatch => {
//   dispatch({
//     type: "landing/loadproducts",
//     userInput: userInput
//   });
// }

// const SearchButton = ({ payload, addToCart, children }) => (
//     <button className="checkoutButton" onClick={() => addToCart(payload)}>{children}</button>
//     );

/*const mapStateToProps = state => ({ items: state.items });*/


// // export default connect(null, (dispatch) => ({
// //   addToCart: (payload) => dispatch(buyItem(payload))
// // }))(BuyButton);
// export default connect(mapStateToPros, {})(Search);