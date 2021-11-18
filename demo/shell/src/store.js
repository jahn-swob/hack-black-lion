import { createStore, applyMiddleware } from 'redux';
import thunk from 'redux-thunk';
import produce from 'immer';

const initialState = {items: []}

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
        const { value } = type;
        const works = state.items.filter(val => val.includes(value));
        return { ...state, value, works };
      }
      default: {
        return draft;
      }
    }
  })

export default createStore(reducer, applyMiddleware(thunk));