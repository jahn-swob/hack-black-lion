import React from "react";
import ReactDOM from "react-dom";
import { connect } from "react-redux";
import "./../styles/index.css";

const ViewProductDetailButton = ({ payload, viewProductDetail, children }) => (
<button className="view-product-detail-button" onClick={() => viewProductDetail(payload)}>{children}</button>
);

function viewItem(payload) {
  return { type: 'productdetail/view', payload }
}

export default connect(null, (dispatch) => ({
  viewProductDetail: (payload) => dispatch(viewItem(payload))
}))(ViewProductDetailButton);