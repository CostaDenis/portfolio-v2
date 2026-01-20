window.applyTheme = function (theme) {
    const root = document.documentElement;

    for (const key in theme) {
        root.style.setProperty(`--${key}`, theme[key]);
    }
};