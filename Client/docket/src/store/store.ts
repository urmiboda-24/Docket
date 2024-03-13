/* eslint-disable prettier/prettier */
import { configureStore } from "@reduxjs/toolkit";
import { persistReducer, persistStore } from "redux-persist";
import storage from "redux-persist/lib/storage";
import createSagaMiddleware from "redux-saga";
import rootReducer from "./rootReducer";
import { rootSaga } from "./rootSaga";

const sagaMiddleware = createSagaMiddleware();
const persistConfig = {
  key: "main-root",
  storage,
  //   blacklist: ["trending"],
};

const persistedReducer: any = persistReducer(persistConfig, rootReducer);

const store = configureStore({
  reducer: persistedReducer,
  middleware: (getDefaultMiddleware: any) => {
    const middlewares = getDefaultMiddleware({
      thunk: false,
    }).concat(sagaMiddleware);
    return middlewares;
  },
});

sagaMiddleware.run(rootSaga);

export default store;

export const persistor = persistStore(store);
