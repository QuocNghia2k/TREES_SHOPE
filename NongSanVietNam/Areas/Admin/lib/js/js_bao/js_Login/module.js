function email(chil, id) {
  var x = chil.value;
  if (x.search("@") == -1 || x == "") {
    document.getElementById(id.id).style.display = "block";
    document.getElementById(chil.id).style.border = "2px solid red";
    document.getElementsByClassName("affter")[0].style.display = "block";
  } else {
    document.getElementById(id.id).style.display = "none";
    document.getElementById(chil.id).style.border = "0";
    document.getElementsByClassName("affter")[0].style.display = "none";
  }
}
function password(chil) {
  var x = chil.value;
  if (x.length < 6 || x == "") {
    document.getElementsByClassName("fillPassword")[0].style.display = "block";
    document.getElementById("password1").style.border = "2px solid red";
    document.getElementsByClassName("affter")[1].style.display = "block";
  } else {
    document.getElementsByClassName("fillPassword")[0].style.display = "none";
    document.getElementById("password1").style.border = "0";
    document.getElementsByClassName("affter")[1].style.display = "none";
  }
}
function fullname(chil, id) {
  var x = chil.value;
  if (x == "") {
    document.getElementById(id.id).style.display = "block";
    chil.style.borderBottom = "2px solid red";
  } else {
    document.getElementById(id.id).style.display = "none";
    chil.style.borderBottom = "0";
  }
}
function email2(chil) {
  var x = chil.value;
  if (x.search("@") == -1 || x == "") {
    document.getElementsByClassName("fillText2")[1].style.display = "block";
    document.getElementById("email2").style.borderBottom = "2px solid red";
  } else {
    document.getElementsByClassName("fillText2")[1].style.display = "none";
    document.getElementById("email2").style.borderBottom = "0";
  }
}
function password2(chil) {
  var x = chil.value;
  if (x.length < 6 || x == "") {
    document.getElementsByClassName("fillText2")[2].style.display = "block";
    chil.style.borderBottom = "2px solid red";
  } else {
    document.getElementsByClassName("fillText2")[0].style.display = "none";
    chil.style.borderBottom = "0";
  }
}
function number(chil, id) {
  var x = chil.value;
  var arr = [];
  for (let i = 0; i < 10; i++) {
    arr.push(i);
  }
  if (x == "") {
    chil.style.border = "2px solid red";
    document.getElementById(id.id).style.display = "block";
  }
  for (let i = 0; i < x.length; i++) {
    if (!arr.includes(parseInt(x[i]))) {
      document.getElementById(id.id).style.display = "block";
      chil.style.border = "2px solid red";
      break;
    } else {
      document.getElementById(id.id).style.display = "none";
      chil.style.border = "0";
    }
  }
}
