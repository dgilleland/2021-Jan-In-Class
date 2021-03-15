function displayTime() {
    let date = new Date();
    let time = date.toLocaleTimeString();
    document.querySelector('.clock').textContent = time;
  }

  displayTime();
  const createClock = setInterval(displayTime, 1000);