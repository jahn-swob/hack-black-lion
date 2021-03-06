import { createStore, applyMiddleware } from 'redux';
import thunk from 'redux-thunk';
import produce from 'immer';

import { products } from 'team-landing/MockedProducts';
const initialState = {items: [],landingItems:products}

const reducer = (state = initialState, {type, payload}) =>
  produce(state, draft => {
    switch (type) {
      case 'cart/add': {
        draft.items.push(payload);
        return draft;
      }
      case 'cart/delete': {
        const { id } = payload;
        draft.items.splice(id, 1);
        return draft;
      }
      case 'search': {
        console.log("YOU HAVE HIT THE SEARCH CASE!!");
        console.log("state", state, "type", type, "payload", payload);
        const { value } = type;
        const items = state.items.filter(val => val.includes(value));
        return { ...state, value, items };
      }
      case 'landing/loadproducts': {
        draft.landingItems.push(payload);
        return draft;
      }
      default: {
        return draft;
      }
    }
  })

export default createStore(reducer, applyMiddleware(thunk));