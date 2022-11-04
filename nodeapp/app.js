var p = new Promise(function(res, rej){
    console.log('A long task');
    //res(5);
    rej('no reason');
});

p.then((data)=>{
    console.log("Completed", data);
}).catch((err)=>{
    console.error(err);
})