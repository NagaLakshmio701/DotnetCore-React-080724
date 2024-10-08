import React, { useState } from "react";
function Counter() {
  const [counter, setCounter] = useState(0);
  const incrementCounter = () => {
    setCounter((prevCounter) => prevCounter + 1);
  };
  const decrementCounter = () => {
    setCounter((prevCounter) => prevCounter - 1);
  };
  return (
    <>
      <button data-testid="increment" onClick={incrementCounter}>
        +
      </button>
      <p data-testid="counter">{counter}</p>
      <button data-testid="decrement" onClick={decrementCounter}>
        -
      </button>
    </>
  );
}
export default Counter;
