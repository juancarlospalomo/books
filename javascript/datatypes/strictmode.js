//Example of strict mode use 
'use strict';

try {
    name = 'Jack'; //this line will fail as name as not declared;
    console.log(name);
} catch (e) {
    console.log ('name is not defined ' + e.message);
}



