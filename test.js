var lis = [1, 2, 3, 4, 5, 6, 7, 8, 8, 8, 9, 9, 1];

let obj = {};

lis.forEach((i) => {

    if (i in obj) {
        obj[i] = obj[i] + 1;
    } else {
        obj[i] = 1;
    }
});


for (i in obj) {

    console.log(`${i} Repeats ${obj[i]} Times `);
}
