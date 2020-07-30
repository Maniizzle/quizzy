﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizzyAPI.Dtos
{

    public class QuestionDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(350, MinimumLength = 6)]
        public string Text { get; set; }
        public Guid? CategoryId { get; set; }
        public IEnumerable<AnswerDto> Answers { get; set; }
    }


    public class UpdateQuestionDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(350, MinimumLength = 6)]
        public string Text { get; set; }
        public Guid? CategoryId { get; set; }
        public IEnumerable<CreateAnswerDto> Answers { get; set; }
    }
}

