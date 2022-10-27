console.log('hi');
var tag = document.getElementById("one");
console.log(tag);
tag.innerText="brijeshpthankachan";
tag.style.color='red';
tag.style.fontFamily = 'cursive';


// gets the parent element of the element
console.log(tag.parentElement); 
tag.parentElement.style.background='ivory';


document.write(' <h1> from javascript </h1> ')


document.write( `

<ul>
<li>one</li>
<li>two</li>
<li>two</li>
</ul>

` );



var paragraphs = document.getElementsByTagName('p');
console.log(paragraphs);


paragraphs[0].style.color='green';