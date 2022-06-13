namespace Minimal_CRUD.MinimalAPI_Services
{
    public static class ArticleAPI
    {
        public static void MapArticleRoutes(this IEndpointRouteBuilder app)
        {
            app.MapGet("/GetArticles", async (IArticleService articleService)
    => await articleService.GetArticles());

            app.MapPost("/CreateArticle", async (ArticleRequest articleRequest, IArticleService articleService)
                => await articleService.CreateArticle(articleRequest));

            app.MapPut("/UpdateArticle/{id}", async (int id, ArticleRequest articleRequest, IArticleService articleService)
                => await articleService.UpdateArticle(id, articleRequest));

            app.MapDelete("/DeleteArticle/{id}", async (int id, IArticleService articleService)
                => await articleService.DeleteArticle(id));

            app.MapGet("/GetArticleByID/{id}", async (int id, IArticleService articleService)
                => await articleService.GetArticleById(id));
        }
    }
}
