const tick = () => {
  location = window.location
  if (location.pathname.endsWith("index.html"))
    window.location.href = './last_name.html'
  else if (location.pathname.endsWith("last_name.html"))
    window.location.href = './index.html'
}

setTimeout(tick, 1000)
