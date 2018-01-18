(function () {
  'use strict';

  function handleResize() {
    if (!canvas) {
      canvas = document.getElementsByTagName('canvas')[0];
    }
    canvas.width = window.innerWidth;
    canvas.height = window.innerHeight;
  }

  function handleUnity(msg) {
    if (msg.detail === "Ready") {
      canvas = document.getElementById('canvas');
      loader = document.getElementById('loader');

      window.addEventListener('resize', handleResize, true);
      handleResize();
      loader.style.display = 'none';
    }
  }

  let display = null,
      canvas = null,
      loader = null;
  document.addEventListener('Unity', handleUnity);
})();
