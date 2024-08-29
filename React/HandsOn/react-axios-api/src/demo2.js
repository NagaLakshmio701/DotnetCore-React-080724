import React, { useState, useEffect } from "react";

const Demo1 = () => {
  const [text, setText] = useState(""); // State to store the text
  const [isFocused, setIsFocused] = useState(false); // State to control focus

  useEffect(() => {
    if (isFocused) {
      const textarea = document.getElementById("textarea");
      textarea.value = "I AM SNL. WELCOME ";
      textarea.focus();
      setIsFocused(false); // Reset focus state
    }
  }, [isFocused]); // Trigger useEffect when isFocused changes

  const onClickHandler = () => {
    setIsFocused(true); // Set focus when the button is clicked
  };

  return (
    <>
      <br />
      <div>
        <button onClick={onClickHandler}>CLICK HERE</button>
      </div>
      <br />
      <textarea id="textarea" value={text} onChange={(e) => setText(e.target.value)} />
    </>
  );
};

export default Demo1;
