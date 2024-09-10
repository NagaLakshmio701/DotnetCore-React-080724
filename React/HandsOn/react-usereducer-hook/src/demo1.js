import react, { useReducer } from "react";
//define initialState and reducer
// const initialState = 0;
const reducer = (state, action) => {
  console.log("s",state)
  console.log("a",action)
  switch (action) {
    case "add":
      return state + 1;
    case "subtract":
      return state - 1;
    case "reset":
      return 0;
    default:
      throw new Error("unexpected action");
  }
};
const Demo1 = () => {
  const [state, dispacth] = useReducer(reducer, 0);
  return (
    <>
      <button onClick={() => dispacth("add")}>+</button>
      <h2>{state}</h2>

      <button onClick={() => dispacth("subtract")}>-</button>
      <button onClick={() => dispacth("reset")}>Reset</button>
    </>
  );
};
export default Demo1;
