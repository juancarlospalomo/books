//Example of strict mode use 
'use strict';

try {
    name = 'Jack'; //this line will fail as name as not declared;
    console.log(name);
} catch (e) {
    console.log (e.message);
}

//Now will declare a var and it will not fail
var surname = 'Nicholson';
console.log(surname);

