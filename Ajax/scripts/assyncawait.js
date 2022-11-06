// async await

let heros = [
  { id: 1, name: "Hanabi", specialization: "Marksman" },
  { id: 2, name: "Zilong", specialization: "Fighter" },
  { id: 3, name: "Haylos", specialization: "Tank" },
  { id: 4, name: "Hayabusa", specialization: "Assasin" },
  { id: 5, name: "Valir", specialization: "Mage" },
];

//  __________________________________________________________________________

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
  

async function display() {
  await insertIntoHeros();
  displayHeros();
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

display();
