* {
  box-sizing: border-box;
  font-family: Ubuntu, sans-serif;
}

html,
body {
  height: 100%;
  padding: 0;
  margin: 0;
}

/* The wrapper contains all of the page's content besides the footer, which is pushed to the bottom of the page */
.wrapper {
  position: relative;
  min-height: 100%;
  padding-bottom: 130px;
  overflow: auto;
}

/* The footer is positioned at the bottom of the page */
.footer {
  position: absolute;
  right: 0;
  bottom: 0;
  left: 0;
  min-height: 100px;
  background: #4e5d6c;
}

/* The code styles the text at the bottom of the footer */
.footer > .bottom {
  position: absolute;
  right: 0;
  bottom: 0;
  left: 0;
  padding: 5px;
  background: #1b3146;
}

.navbar {
  padding: 5px;
  margin: 0;
}

/* This CSS styles the ufo icon in the navbar */
.nav-ufo {
  position: absolute;
  bottom: 5px;
  left: 150px;
  width: 35px;
  color: white;
}

/* Adding styles to the aside and filter form */
.ufo-form {
  margin-top: 50px;
}

.filters .panel-body {
  padding: 0;
}

.filters {
  margin-top: 10px;
}

select {
  display: block;
  width: 100%;
  padding: 8px;
  color: #8e979f;
  outline: none;
}

#table-area th {
  text-align: center;
}

#table-area th:first-child,
#table-area th:nth-child(2),
#table-area th:nth-child(6) {
  min-width: 70px;
}

.loader {
  margin-top: 50px;
}

.margin-top-50 {
  margin-top: 50px;
}

/* The styles for the parallax */
.hero {
  position: relative;
  height: 550px;
  padding: 20px;
  margin: 0;
  background: black;
  background-image: url("../images/nasa.jpg");
  background-attachment: fixed;
  background-position: bottom center;
  background-size: cover;
}

.hero h1 {
  margin-top: 200px;
  font-size: 0.1rem;
  animation: title 1.2s forwards linear;
}

.hero p {
  font-size: 2rem;
  opacity: 0;
  animation: subtitle 1.2s forwards linear;
  animation-delay: 1.2s;
}

/* input placeholder color changes */
.form-control::-webkit-input-placeholder {
  /* Chrome/Opera/Safari */
  color: #8e979f;
}

.form-control::-moz-placeholder {
  /* Firefox 19+ */
  color: #8e979f;
}

.form-control:-ms-input-placeholder {
  /* IE 10+ */
  color: #8e979f;
}

.form-control:-moz-placeholder {
  /* Firefox 18- */
  color: #8e979f;
}

/* media queries which will only be activated at specific screen sizes */
@media (max-width: 800px) {
  #table-area td {
    font-size: 1em;
  }
}

@media (max-width: 500px) {
  #table-area thead {
    display: none;
  }

  #table-area tr td:first-child {
    font-size: 1.8em;
    font-weight: bold;
    background: #1b3146;
  }

  #table-area tr td:last-child {
    margin-bottom: 20px;
  }

  #table-area tr td:last-child::after {
    display: block;
    width: 100%;
    height: 1px;
    margin-top: 20px;
    content: " ";
    background: aliceblue;
  }

  #table-area td {
    font-size: 1.25em;
  }

  #table-area tbody td {
    display: block;
    text-align: center;
  }

  #table-area tbody td::before {
    display: block;
    font-size: 1.4em;
    font-weight: bold;
    text-align: center;
    content: attr(data-th);
  }

  .hero h1 {
    animation: smaller-title 1.2s forwards linear;
  }
}

/* keyframe animations which will be used to animate the title */
@keyframes title {
  from {
    opacity: 0;
  }

  to {
    font-size: 7.5rem;
    opacity: 1;
  }
}

@keyframes smaller-title {
  from {
    opacity: 0;
  }

  to {
    font-size: 5.5rem;
    opacity: 1;
  }
}

@keyframes subtitle {
  from {
    opacity: 0;
  }

  to {
    opacity: 1;
  }
}