


function getData(){
    fetch('https://reqres.in/api/users?page=').then(
        res => res.json()
    ).then( data =>{


        document.getElementById('tbody').innerHTML='';


        data.data.forEach(user => {
            
            var row = `
            <tr>
                <td>${user.id}</td>
                <td>${user.first_name}</td>
                <td>${user.last_name}</td>
                <td>${user.email}</td>
            </tr>
        `;
        document.getElementById('tbody').innerHTML += row;
        });
    } )
    
}
