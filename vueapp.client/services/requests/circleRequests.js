export const getById = async (id) => {
  const data = fetch(`https://localhost:7239/api/circles/${id}`, {
    headers: { "Content-Type": "application/json" },
  })
    .then((res) => res.json())
    .then((json) => json)
    .catch((error) => error);

  const circles = await data;

  return circles;
};

export const postCircle = (circle) => {
  fetch(`https://localhost:7239/api/circles`, {
    method: "POST",
    headers: { "Content-Type": "application/json" },
    body: JSON.stringify(circle),
  })
    .then((res) => res.json())
    .then((json) => json)
    .catch((error) => {
      console.log("post error:", error);
      return error;
    });
};
