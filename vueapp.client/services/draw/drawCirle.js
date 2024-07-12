export const drawCircle = (x, y, canvas) => {
  const ctx = canvas.getContext("2d");
  const radius = Math.floor(Math.random() * 50) + 10;
  const color = `#${Math.floor(Math.random() * 16777215).toString(16)}`;
  ctx.beginPath();
  ctx.arc(x, y, radius, 0, 2 * Math.PI);
  ctx.stroke();
  ctx.fillStyle = color;
  ctx.fill();

  return {color: color, radius: radius}
};

export const drawFixedCircle = (canvas, circle) => {
  const ctx = canvas.getContext("2d");
  ctx.beginPath();
  ctx.arc(circle.x, circle.y, circle.radius, 0, 2 * Math.PI);
  ctx.stroke();
  ctx.fillStyle = circle.color;
  ctx.fill();
};

