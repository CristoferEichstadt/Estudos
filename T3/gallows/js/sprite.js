function createSprite(selector) {

    var elemento = $(selector);

    var frames = ['frame1', 'frame2', 'frame3', 'frame4', 'frame5','frame6', 'frame7', 'frame8', 'frame9'];

    var ultimo = frames.length -1; 
    var atual = 0;
    var proximo = ++atual;

    elemento.addClass(frames[atual]);  

    function nextFrame() {

        elemento.removeClass(frames[atual]).addClass(frames[proximo]);
    }
}