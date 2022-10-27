console.log('hi');
var tag = document.getElementById("one");
console.log(tag);
tag.innerText = "brijeshpthankachan";
tag.style.color = 'red';
tag.style.fontFamily = 'cursive';


// gets the parent element of the element
console.log(tag.parentElement);
tag.parentElement.style.background = 'ivory';


document.write(' <h1> from javascript </h1> ')


document.write(`

<ul>
<li>one</li>
<li>two</li>
<li>two</li>
</ul>

` );



var paragraphs = document.getElementsByTagName('p');
console.log(paragraphs);


paragraphs[0].style.color = 'green';


//  using inneeHTML for manipulating dom makes vulnerabilities and also inefficent


for (var i = 0; i < 50; i++) {

    var di = document.getElementById('button');
    di.innerHTML += ` 
    

      <button>${i}</button>


    `
}



var x = document.getElementsByTagName('button');

for (var i = 0; i < x.length; i++) {

    x[i].style.background = `rgb(255, ${i+100} , ${i+20})`;
    x[i].style.margin = '5px'

}





// using nodelist
// node list allows to use advanced css selectors

var qs = document.querySelectorAll('div div button')
qs.forEach(e => {

    e.style.background = 'green';
}
)




// creating elements from javascipt , dom manipulation  


var p = document.createElement('p');
p.innerText= "Paragraph created by js";

document.getElementById('button').appendChild(p);



var table = document.createElement('table');
var raw = document.createElement('tr');
var col = document.createElement('td');

raw.innerText="raw";
col.innerText="column";

document.getElementById('table').appendChild(table).appendChild(raw).appendChild(col);



// e is the event object

function clickevent(e){

    // alert("clicked");
    e.target.innerText = 'clicked';
}


var yar = document.getElementById('x');

console.log(yar);


function hide(){


    yar.style.display="none";

}

function show(){

    yar.style.display="block";


}


document.querySelectorAll('button').forEach(e=>{

    e.addEventListener('click',()=>{

        // console.log("button clicked");
        e.classList.add('bg-primary');
        e.classList.remove('txt-white');
    })
})




document.querySelectorAll('button').forEach(e=>{


        // console.log("button clicked");
        e.classList.add('bg-primary');
        e.classList.remove('txt-white');
    
})
