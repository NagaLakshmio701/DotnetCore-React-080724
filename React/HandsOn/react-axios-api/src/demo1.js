import {React,useRef}from "react";


const Demo=()=>{
const Focus=useRef(null);

const onClickHandler=()=>{
    Focus.current.value="I AM SNL. WELCOME "
    Focus.current.focus();
}

return(
    <>
    <br/>
    <div>
    <button onClick={onClickHandler}>CLICK HERE</button></div>
   <br/>
    <textarea ref={Focus}></textarea>
    
    </>
)


}

export default Demo