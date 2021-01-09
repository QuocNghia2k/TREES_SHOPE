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
  var s = document.getElementById(id.id).value;
  if (!check_email("inputEmail")) {
    console.log("asdfsf");
    if (!vali_isPassword(s)) {
      document.getElementById("require-password").style.display = "block";
      return true;
    }
    if (vali_isPassword(s)) {
      document.getElementById("require-password").style.display = "none";
      return false;
    }
  }
}
