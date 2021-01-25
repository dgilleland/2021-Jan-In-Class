// Practice Solution

const featureLinkHandler = function (evt) {
    var featureImage = document.querySelector('img.feature');
    featureImage.src = featureLink.href;
    featureImage.classList.remove('hidden');
    evt.preventDefault();
}

var featureLink = document.querySelector('a.feature.link');

featureLink.addEventListener('click', featureLinkHandler);
