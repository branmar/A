//-----1-----
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};

var sum = salaries.John + salaries.Ann + salaries.Pete;
console.log(sum);

//-----2-----
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

function multiplyNumeric(obj) {
    for (var e in obj) {
        if (typeof obj[e] == "number") {
            obj[e] *= 2;
        }
    }
}

console.log(menu);
multiplyNumeric(menu);
console.log(menu);

//-----3-----
const emailRegEx = /^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$/;
var email = "testEmail@gmail.com";
function checkEmailId(str) {
    if (emailRegEx.test(str)) {
        return true;
    } else {
        return false;
    }
}

console.log(checkEmailId(email));

//-----4-----
function truncate(str, maxlength) {
    if (str.length > maxlength) {
        return str.substr(0, maxlength - 1) + "...";
    } else {
        return str;
    }
}
console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

//-----5-----
const styles = ["James", "Brennie"];
console.log(styles);
styles.push("Robert");
console.log(styles);
styles[Math.round(styles.length / 2 - 1)] = "Calvin";
console.log(styles);
styles.splice(0, 1);
console.log(styles);
styles.splice(0, 0, "Rose", "Regal");
console.log(styles);