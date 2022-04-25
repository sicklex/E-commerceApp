import {
  Button,
  Card,
  CardContent,
  TextField,
  Typography,
} from "@mui/material";
import { Box } from "@mui/system";
import React from "react";
import Center from "../Components/Center";
import useForm from "../Hooks/UserForm";

const getFreshModel = () => ({
  Password: "",
  email: "",
});

function Login() {
  const { values, setValues, errors, setErrors, handleInputChange } =
    useForm(getFreshModel);

  const validate = () => {
    let temp = {};
    temp.email = /\S+@\S+\.\S+/.test(values.email) ? "" : "Email is not valid";
    temp.Password = values.Password !== "" ? "" : "This field is required";
    setErrors(temp);
    return Object.values(temp).every(x => x === "");
  };

  const handleSubmit = e => {
    e.preventDefault();
    if (validate()) {
      console.log("Submitted");
    }
  };

  return (
    <Center>
      <Card sx={{ width: 400 }}>
        <CardContent sx={{ textAlign: "center" }}>
          <Typography variant="h3" sx={{ my: 3 }}>
            Login
          </Typography>
          <Box
            sx={{
              "& .MuiTextField-root": {
                width: "90%",
                m: 1,
              },
            }}
          >
            <form onSubmit={handleSubmit}>
              <TextField
                label="Email"
                name="email"
                value={values.email}
                onChange={handleInputChange}
                variant="outlined"
                {...(errors.email && { error: true, helperText: errors.email })}
              />
              <TextField
                label="Password"
                name="Password"
                value={values.name}
                onChange={handleInputChange}
                variant="outlined"
                {...(errors.Password && {
                  error: true,
                  helperText: errors.Password,
                })}
                type="password"
              />
              <Button
                type="Submit"
                variant="contained"
                size="large"
                sx={{
                  width: "90%",
                }}
              >
                Login
              </Button>
            </form>
          </Box>
        </CardContent>
      </Card>
    </Center>
  );
}

export default Login;
