var btn = document.querySelectorAll("button");

console.log(btn);

btn.forEach(e=>{

    e.addEventListener('click',()=>{

        let play = document.getElementById("dis");
        console.log(play.value)

        if(e.value==='='){

            try {
                play.innerText=eval(play.value);

            } catch (error) {
                play.innerHTML="ERROR press clear to continue "
            
            }
            
        }
        else if(e.value==='clr'){

            play.innerText="";
        }
        else{

            play.innerText=play.value+e.value;
            console.log(e.value);

        }

    })
})