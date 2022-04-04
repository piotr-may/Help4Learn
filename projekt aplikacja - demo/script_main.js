
document.querySelector('#settings').addEventListener('click', ()=>{
    document.querySelector('.menu').classList.toggle('hided');
    menuAnimation();
});

document.querySelector('#x').addEventListener('click', ()=>{
    document.querySelector('.menu').classList.toggle('hided');
});


//tests_callendar

document.querySelector('#callendar').addEventListener('click', ()=>{
    let kalendarz = document.querySelector('.callendar');
    if(kalendarz.style.display == 'none' ||  kalendarz.style.display=='') kalendarz.style.display = 'block';
    else kalendarz.style.display = 'none';
});
document.querySelector('#learning').addEventListener('click', ()=>{
    let kalendarz = document.querySelector('.tests_callendar');
    if(kalendarz.style.display == 'none' ||  kalendarz.style.display=='') kalendarz.style.display = 'block';
    else kalendarz.style.display = 'none';
});


var id = null;
function menuAnimation() {
    var elem = document.querySelector(".menu");   
    var pos = 620;
    clearInterval(id);
    id = setInterval(frame, 1);
    function frame() {
        if (pos < 350) {
            clearInterval(id);
        } 
        else {
            pos-=4; 
            elem.style.top = pos + 'px'; 
        }
    }  
}