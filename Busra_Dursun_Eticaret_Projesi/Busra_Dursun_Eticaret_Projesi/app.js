const slides = document.querySelectorAll(".slide");
const btnPrev = document.querySelector("#prev");
const btnNext = document.querySelector("#next");

let autoSlider = true;
let sliderInterval;
let intervalTime = 5000;

btnPrev.addEventListener("click", function () {
    prevSlide();
    againInterval();

});

btnNext.addEventListener("click", function () {
    nextSlide();
    againInterval();

});

function prevSlide() {
    let activeSlide = document.querySelector(".active");
    activeSlide.classList.remove("active");
    if (activeSlide.previousElementSibling) {
        activeSlide.previousElementSibling.classList.add("active");
    } else {
        slides[slides.length - 1].classList.add("active");
    }
}

function nextSlide() {
    let activeSlide = document.querySelector(".active");
    activeSlide.classList.remove("active");
    if (activeSlide.nextElementSibling && activeSlide.nextElementSibling.classList.contains("slide")) {
        activeSlide.nextElementSibling.classList.add("active");
    } else {
        slides[0].classList.add("active");
    }
}

function againInterval() {
    if (autoSlider) {
        clearInterval(sliderInterval)
        sliderInterval = setInterval(nextSlide, intervalTime);
    }
};

if (autoSlider) {
    againInterval();
}