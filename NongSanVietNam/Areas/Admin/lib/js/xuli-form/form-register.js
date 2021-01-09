function vali_isEmail(text) {
  const regex = /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/g;
  const result = regex.test(text);
  return result;
}
function vali_isPassword(text) {
  const regex = /^(?=.*[a-z])(?=.*[a-zA-Z]).{8,}$/g;
  const result = regex.test(text);
  return result;
}
function vali_isText(text) {
  const regex = /[0-9`~!@#$%^&*()_+-={}\|'";:?.><,]/g;
  const result = regex.test(text);
  return !result;
}
function vali_PhoneNumber(text) {
  const regex = /^(09|01[2|6|8|9])+([0-9]{8})\b/g;
  const result = regex.test(text);
  return result;
}
function vali_isEmpty(text) {
  if (text === "") {
    return true;
  }
  return false;
}
function check_email(id) {
  var s = document.getElementById(id).value;
  if (!vali_isEmail(s)) {
    document.getElementById("require-email").style.display = "block";
    return true;
  }
  if (vali_isEmail(s)) {
    document.getElementById("require-email").style.display = "none";
    return false;
  }
}
function check_password(id) {
  var s = document.getElementById(id).value;
  if (!vali_isPassword(s)) {
    document.getElementById("require-password").style.display = "block";
    return true;
  }
  if (vali_isPassword(s)) {
    document.getElementById("require-password").style.display = "none";
    return false;
  }
}
function check_password2(id, id2) {
  var s = document.getElementById(id).value;
  var s2 = document.getElementById(id2).value;
  if (s != s2) {
    document.getElementById("require-password2").style.display = "block";
  } else {
    document.getElementById("require-password2").style.display = "none";
  }
}
function check_phone(id) {
  var s = document.getElementById(id).value;
  if (!vali_PhoneNumber(s)) {
    document.getElementById("require-phone").style.display = "block";
    return true;
  }
  if (vali_PhoneNumber(s)) {
    document.getElementById("require-phone").style.display = "none";
    return false;
  }
}
function check_name(id) {
  var s = document.getElementById(id).value;
  if (vali_isEmpty(s)) {
    document.getElementById("require-lname").style.display = "block";
    return true;
  } else {
    document.getElementById("require-lname").style.display = "none";
    if (!vali_isText(s)) {
      document.getElementById("require-lname2").style.display = "block";
      return true;
    }
    if (vali_isText(s)) {
      document.getElementById("require-lname2").style.display = "none";
      return false;
    }
  }
}
function check_name2(id) {
  var s = document.getElementById(id).value;
  if (vali_isEmpty(s)) {
    document.getElementById("require-fname").style.display = "block";
    return true;
  } else {
    document.getElementById("require-fname").style.display = "none";
    if (!vali_isText(s)) {
      document.getElementById("require-fname2").style.display = "block";
      return true;
    }
    if (vali_isText(s)) {
      document.getElementById("require-fname2").style.display = "none";
      return false;
    }
  }
}
