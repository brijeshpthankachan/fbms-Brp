


function drive(){


    document.getElementById('drive').classList.add('bg-dark','text-light');
    document.getElementById('ride').classList.remove('bg-dark','text-light'); 

    document.getElementById('drive-div').style.display='block';
    document.getElementById('ride-div').classList.add('d-none');
    document.getElementById('divbtn').innerText="Sign up Now";
}

function ride(){


    document.getElementById('ride').classList.add('bg-dark','text-light'); 
    document.getElementById('drive').classList.remove('bg-dark','text-light');
    document.getElementById('drive-div').style.display='none';
    document.getElementById('ride-div').classList.remove('d-none');
    document.getElementById('divbtn').innerText="Request a ride / ";

}



function validate(){

    // alert("succesfully signed in");S

    var list = document.querySelectorAll("#form1 input");
    // console.log(list);
    list.forEach((e)=>{

        e.addEventListener("keyup",function(event){

            

        })
    });

}

function signin(){

    document.getElementById('signup').style.display='none';
    document.getElementById('signin').classList.remove('d-none');
    
}



