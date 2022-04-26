import React from "react";
import { Grid } from "@mui/material";

function Center({ children }) {
  return (
    <Grid
      container
      direction="column"
      justifyContent="center"
      alignItems="center"
      sx={{ minHeight: "100vh" }}
    >
      <Grid item xs={1}>
        {children}
      </Grid>
    </Grid>
  );
}

export default Center;
