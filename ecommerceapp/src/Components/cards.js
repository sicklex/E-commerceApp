import * as React from "react";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { CardActionArea } from "@mui/material";
import TEXT from "../Utils/texts";

export default function ActionAreaCard({ text, image, title }) {
  let textLeng = text => {
    if (text.length > 200) return text.substring(0, 200) + "...";
  };

  return (
    <Card
      sx={{
        maxWidth: 345,
      }}
    >
      <CardActionArea>
        <CardMedia
          component="img"
          height="250"
          image={image}
          alt="green iguana"
        />
        <CardContent>
          <Typography gutterBottom variant="h5" component="div">
            {title}
          </Typography>
          <Typography variant="body2" color="text.secondary">
            {textLeng(text)}
          </Typography>
        </CardContent>
      </CardActionArea>
    </Card>
  );
}
