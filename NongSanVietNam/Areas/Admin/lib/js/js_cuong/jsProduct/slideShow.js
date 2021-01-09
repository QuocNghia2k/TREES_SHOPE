var countSlide = 0;
var arrSlide =[document.getElementById('img1').src,document.getElementById('img2').src,document.getElementById('img3').src,document.getElementById('img4').src]
console.log(arrSlide);
document.getElementById('next').onclick=function next(){
  countSlide++;
  if(countSlide<4){
  var t = document.getElementById("img");
  t.src = arrSlide[countSlide];
  }else{
    countSlide = 0;
    var t = document.getElementById("img");
    t.src = arrSlide[countSlide];
  }

}
document.getElementById('pre').onclick=function pre(){
  countSlide--;
  if(countSlide>=0){
  var t = document.getElementById("img");
  t.src = arrSlide[countSlide];
  }else{
    countSlide = arrSlide.length-1;
    var t = document.getElementById("img");
    t.src = arrSlide[countSlide];
  }
}


function change(path){
    var t = document.getElementById("img");
  t.src = path;
  console.log(t.src);
}








var send =document.getElementById("send");
var checkClick = true;
send.onclick=function send(){
  var dt = document.getElementById("formReview");
  if(checkClick==true){
  dt.style.display="block";
  var send =document.getElementById("send").innerHTML = "Đóng";
  checkClick = false;
}else{
  dt.style.display="none";
  var send =document.getElementById("send").innerHTML = "Gửi đánh giá của bạn";
  checkClick = true;
  }
}


var send1 =document.getElementById("send1");
var checkClick1 = true;
send1.onclick=function send1(){
  var dg = document.getElementById("formReview1");
  if(checkClick1==true){
  dg.style.display="block";
  var send =document.getElementById("send1").style.display="none";
  document.getElementById("close").style.display="block"
  checkClick1 = false;
}
}
document.getElementById("close").onclick = function closeTxt(){
  var dg = document.getElementById("formReview1");
  if(checkClick1==false){
  dg.style.display="none";
  var send =document.getElementById("send1").style.display="block";
  document.getElementById("close").style.display="none"
  checkClick1 = true;
}
}


