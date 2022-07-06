@charset "UTF-8";
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-weight: normal;
}

:root {
  --bg_main: #0a1f44;
  --text_light: #fff;
  --text_med: #53627c;
  --text_dark: #1e2432;
  --red: #ff1e42;
  --darkred: #c3112d;
  --orange: #ff8c00;
}

a {
  color: inherit;
  text-decoration: none;
}

button {
  cursor: pointer;
}

input {
  -webkit-appearance: none;
}

button,
input {
  border: none;
  background: none;
  outline: none;
  color: inherit;
}

img {
  display: block;
  max-width: 100%;
  height: auto;
}

ul {
  list-style: none;
}

body {
  font: 1rem/1.3 "Roboto", sans-serif;
  background: var(--bg_main);
  color: var(--text_dark);
  padding: 70px;
}

.container {
  width: 100%;
  max-width: 1200px;
  margin: 0 auto;
  padding: 0 15px;
}

.openweather-banner {
  display: none;
}

/* SECTION #1
  –––––––––––––––––––––––––––––––––––––––––––––––––– */
.top-banner {
  color: var(--text_light);
}

.heading {
  font-weight: bold;
  font-size: 4rem;
  letter-spacing: 0.02em;
  padding: 0 0 30px 0;
}

.top-banner form {
  position: relative;
  display: flex;
  align-items: center;
}

.top-banner form input {
  font-size: 2rem;
  height: 40px;
  padding: 5px 5px 10px;
  border-bottom: 1px solid;
}

.top-banner form input::placeholder {
  color: currentColor;
}

.top-banner form button {
  font-size: 1rem;
  font-weight: bold;
  letter-spacing: 0.1em;
  padding: 15px 20px;
  margin-left: 15px;
  border-radius: 5px;
  background: var(--red);
  transition: background 0.3s ease-in-out;
}

.top-banner form button:hover {
  background: var(--darkred);
}

.top-banner form .msg {
  position: absolute;
  bottom: -40px;
  left: 0;
  max-width: 450px;
  min-height: 40px;
}

/* SECTION #2
  –––––––––––––––––––––––––––––––––––––––––––––––––– */
.reset {
  visibility: hidden;
}

.closebtn {
  background: none;
  position: relative;
  width: 30px;
  height: 30px;
  opacity: 0.4;
  left: 13rem;
}
.closebtn:before, .closebtn:after {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  right: 0;
  height: 4px;
  background: rgb(26, 24, 24);
  border-radius: 4px;
}
.closebtn:before {
  transform: rotate(45deg);
}
.closebtn:hover {
  opacity: 1;
}
.closebtn:after {
  transform: rotate(-45deg);
}

.weather-section {
  margin: 70px 0 20px;
}

.weather-section .cities {
  display: grid;
  grid-gap: 32px 20px;
  grid-template-columns: repeat(4, 1fr);
}

.weather-section .city {
  position: relative;
  padding: 40px 10%;
  border-radius: 20px;
  background: var(--text_light);
  color: var(--text_med);
}

.weather-section .city::after {
  content: "";
  width: 90%;
  height: 50px;
  position: absolute;
  bottom: -12px;
  left: 5%;
  z-index: -1;
  opacity: 0.3;
  border-radius: 20px;
  background: var(--text_light);
}

.weather-section figcaption {
  margin-top: 10px;
  text-transform: uppercase;
  letter-spacing: 0.05em;
}

.weather-section .city-temp {
  font-size: 5rem;
  font-weight: bold;
  margin-top: 10px;
  color: var(--text_dark);
}

.weather-section .city sup {
  font-size: 0.5em;
}

.weather-section .city-name sup {
  padding: 0.2em 0.6em;
  border-radius: 30px;
  color: var(--text_light);
  background: var(--orange);
}

.weather-section .city-icon {
  margin-top: 10px;
  width: 100px;
  height: 100px;
}

/* FOOTER
  –––––––––––––––––––––––––––––––––––––––––––––––––– */
.page-footer {
  text-align: right;
  font-size: 1rem;
  color: var(--text_light);
  margin-top: 40px;
}

.page-footer span {
  color: var(--red);
}

/* MQ
  –––––––––––––––––––––––––––––––––––––––––––––––––– */
@media screen and (max-width: 1023px) {
  body {
    padding: 30px;
  }
  .weather-section .cities {
    grid-template-columns: repeat(3, 1fr);
  }
}
@media screen and (max-width: 1023px) {
  .heading,
.weather-section .city-temp {
    font-size: 3rem;
  }
  .weather-section {
    margin-top: 20px;
  }
  .top-banner form {
    flex-direction: column;
    align-items: flex-start;
  }
  .top-banner form input,
.top-banner form button {
    width: 100%;
  }
  .top-banner form button {
    margin: 20px 0 0 0;
  }
  .top-banner form .msg {
    position: static;
    max-width: none;
    min-height: 0;
    margin-top: 10px;
  }
  .weather-section .cities {
    grid-template-columns: repeat(2, 1fr);
  }
}
@media screen and (max-width: 1023px) {
  body {
    padding: 15px;
  }
  .weather-section .cities {
    grid-template-columns: repeat(1, 1fr);
  }
}
/* API Key banner
  –––––––––––––––––––––––––––––––––––––––––––––––––– */
.api a {
  text-decoration: underline;
}

.api a:hover {
  text-decoration: none;
}

/*# sourceMappingURL=home.cs.map */
