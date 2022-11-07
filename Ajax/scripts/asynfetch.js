async function wait() {
  let x = await (
    await fetch("https://jsonplaceholder.typicode.com/users")
  ).json();
  console.log(x);
}




let num = 1;

async function iter() {
return new Promise((resolve,reject)=>{
    for (; num <= 1000000000; num++);
})
}





wait();
iter();
console.log(num);
