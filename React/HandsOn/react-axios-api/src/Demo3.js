import React, {useRef} from "react";

export default  function Demo3(){
    const age =useRef();
    const uname=useRef();

    const onsubmit=(e)=>{

        e.preventDefault()

        // alert( hai ${uname.current.value})

    }



}