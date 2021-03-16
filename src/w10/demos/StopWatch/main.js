function displayTime() {
    let date = new Date();
    let time = date.toLocaleTimeString();
    document.querySelector('.clock').textContent = time;
  }

  displayTime();
  const createClock = setInterval(displayTime, 1000);

const calcTimer = function (total) {
    let hours = Math.floor(total / 3600);
    let minutes = Math.floor((total - hours * 3600) / 60);
    let seconds = total % 60;
    return {hours, minutes, seconds};
}
