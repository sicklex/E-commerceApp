import React, { useEffect, useMemo, useState } from "react";
import { SLIDER_DATA } from "../SliderData";
import ArrowBackIosIcon from "@mui/icons-material/ArrowBackIos";
import ArrowForwardIosIcon from "@mui/icons-material/ArrowForwardIos";
import "./ImageSlider.css";

const ImageSlider = () => {
  const [current, setCurrent] = useState(0);
  const length = SLIDER_DATA.length;
  const nextSlide = () => setCurrent(current === length - 1 ? 0 : current + 1);
  const prevSlide = () => setCurrent(current === 0 ? length - 1 : current - 1);

  useEffect(() => {
    const interval = setInterval(() => {
      nextSlide();
    }, 3000);
    return () => clearInterval(interval);
  }, [current]);

  if (!Array.isArray(SLIDER_DATA) || SLIDER_DATA.length <= 0) return null;

  return (
    <div className="slider-wrapper">
      <ArrowBackIosIcon className="left-arrow" onClick={nextSlide} />
      <div className="slider">
        {SLIDER_DATA.map((slide, index) => {
          return (
            <div
              className={index === current ? "slide active" : "slide"}
              key="index"
            >
              {index === current && (
                <img src={slide.image} alt="slide" className="image" />
              )}
            </div>
          );
        })}
      </div>
      <ArrowForwardIosIcon className="right-arrow" onClick={prevSlide} />
    </div>
  );
};

export default ImageSlider;
