//This script shows examples to understand undefined property well
//A variable is undefined if it has not been assigned any value
var name;

//check if name var is undefined
if (name == undefined) {
    //it will print this out
    console.log("name var is " + name);
} else {
    console.log(name);
}

//check if name var is undefined and its type it is undefined too
if (name === undefined) {
    //It will print this out
    console.log("name var is " + name + " type: " + typeof (name));
} else {
    console.log(name);
}

name = null; //set value equal to null
//check if name var is undefined
if (name == undefined) {
    //It will print this out
    console.log("name var is undefined");
} else {
    console.log(name);
}

//check if name var is undefined and its type it is undefined too
if (name === undefined) {
    console.log("name var is " + name);
} else {
    //It will print this out, because its type is object
    console.log(name + " type: " + typeof (null));
}

if (!name) {
    //undefined eval to false, so if it is undefined this comparation will return true
    console.log("is defined = false");
    console.log(!undefined);
}