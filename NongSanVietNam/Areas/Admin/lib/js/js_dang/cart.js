function addcart(id) {
  var el = document.getElementById(id);
  var va = parseInt(el.innerHTML);
  el.innerHTML = va + 1;
  document.getElementById(id).style.display = "block";
}
