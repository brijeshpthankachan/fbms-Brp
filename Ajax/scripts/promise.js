let heros = [
  { id: 1, name: "Hanabi", specialization: "Marksman" },
  { id: 2, name: "Zilong", specialization: "Fighter" },
  { id: 3, name: "Haylos", specialization: "Tank" },
  { id: 4, name: "Hayabusa", specialization: "Assasin" },
  { id: 5, name: "Valir", specialization: "Mage" },
];

//  __________________________________________________________________________

// "I Promise a Result!"
// "Producing code" is code that can take some time
// "Consuming code" is code that must wait for the result
// A Promise is a JavaScript object that links producing code and consuming code

// https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/Promise

// ____________________________________________________________________________

function insertIntoHeros() {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      heros.push({ id: 6, name: "Lesely", specialization: "Marksman" });

      const err = false;

      !err ? resolve() : reject("Somthing went wrong from reject :) ");
    }, 1000);
  });
}

// _____________________________________________________________________________


function displayHeros() {
  let tableID = document.getElementById("tbody");

  heros.forEach((hero) => {
    tableID.innerHTML += `
          
        <tr> 
        <td>${hero.id} </td>
        <td>${hero.name} </td>
        <td>${hero.specialization}</td>
        </tr>
          
        `;
  });
}

// _____________________________________________________________________________

insertIntoHeros()
  .then(displayHeros)
  .catch((e) => {
    console.log(e);
  });
