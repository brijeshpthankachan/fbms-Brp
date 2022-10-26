console.log("hi");

function sum(a) {
  console.log(a.length);
  console.log(a);
}

function proto() {
  var a = [1, 2, 3, 4, 5];
  sum(a);
}

function diff(x, y) {
  if (x === y) return `${x} = ${y}`;
  else if (x > y) return `${x} is grater than ${y}`;
  else return `${x} is less than ${y}`;
}

if (true) {
  // var blocks has a global scope

  var var1 = "this is a var variable";

  // let variables only have local scope;

  let var2 = "this a a let variable";
}

// a is defined inside a function it,s scope is inside that function
// this gives an error
// console.log(a)

console.log(var1);

// this gives an error
// console.log(var2);

proto();
console.log(diff(10, 9));
console.log(diff(10, 10));
console.log(diff(8, 9));

// console.log(a.length)

// --------------------------------------------------------------------
// Looping
// ====================================================================

var a = [10, 9, 8, 7, 6, 7, 8, 4, 5];

function sumUsingForLoop(x) {
  let forSum = 0;

  // use let for initialization variable for preserving the scope

  for (let i = 0; i < x.length; i++) {
    forSum += x[i];
  }

  return forSum;
}

function sumUsingWhileLoop(x) {
  let i = 0;
  let whileSum = 0;
  while (i < x.length) whileSum += x[i++];

  return whileSum;
}

console.log(`sum using for loop ${sumUsingForLoop(a)}`);
console.log(`sum using while loop ${sumUsingWhileLoop(a)}`);

// ===============================================================

function multiplicationTable(x) {
  for (let i = 1; i <= 12; i++) console.log(`${x} * ${i} = ${i * x}`);
  return 0;
}

console.log(multiplicationTable(8));

// ================================================================

function loopExercise() {
  for (;;) {
    console.log("press q to exit");
    a = prompt("press q to exit from [ from for ] ");
    if (a === "q") break;
  }

  while (true) {
    console.log("press q to exit");
    var a = prompt("press q to exit [ from while ] ");
    if (a === "q") break;
  }
}

// ========================================================

// Exceptions

try {
  console.log(ok);
} catch (e) {
  console.log("an error has occured");
}

// ------------------------------------------------------------------

// Exercise

function authentication() {
  if (prompt("Enter email") === "abc@gmail" && prompt("enter pass") === "pass")
    return true;
  return false;
}

// anonymous functions

var add = function (x, y) {
  return x + y;
};

console.log(add(6, 7));

// -------------------------------

var add = (x, y) => {
  return x + y;
};

console.log(add(6, 9));

// --------------------------------------

var add = (x, y) => {
  return x + y;
};

console.log(add(6, 89));

// if(!authentication()){
//     console.log("login failed")
// }
// else{
//     console.log("login Sucess")
// }

// ==================================================

// Object

var persons = {
  firstName: "Brijesh",
  middleName: "P",
  lastName: "Thankachan",
  age: 23,
};
console.log(persons);

// fetching data from an object

console.log(persons.firstName);
console.log(persons["lastName"]);

// changing value

persons.firstName = "jhon";

console.log(persons);

// ----------------------------------------------------------

var student = {
  id: 1,
  mark1: 80,
  mark2: 90,
  name_: "brijesh",
  phone: [8547516601, 6282514395],
  total: function () {
    return this.mark1 + this.mark2;
  },
};

console.log(student);
console.log(student.phone[1]);

switch (3) {
  case 1:
  case 2:
  case 3:
    console.log("ok");
    break;
  case 4:
    console.log("po");
}

console.log(student.total());


// ============================================================
// exercise 

function largest(x) {
  max = parseInt(x[0]);
  for (var i = 1; i <= x.length; i++) {
    if (parseInt(x[i]) > max) max = parseInt(x[i]);
  }
  return max;
}

// var d = prompt("enter five numbers space seperated");

// console.log(largest(d.split(" ")));


var names=['asdsada','xcxccx','wewewe']

names.forEach((name)=>{
    console.log(name.toUpperCase());
})


